import json
import time
from functions import medline_formatting, progress_bar

class Efetch:
    def __init__(self, session, UIDs):
        self.session = session
        self.UIDs = UIDs
    
    def get_data_UID(self, UID):
        time.sleep(0.25)
        url = 'https://eutils.ncbi.nlm.nih.gov/entrez/eutils/efetch.fcgi?db=pubmed&rettype=medline&id='
        url = url + UID
        site = self.session.get(url).content

        data = site.decode()
        data = medline_formatting(data)

        return data
    
    def get_data_UIDs(self):
        title  = []
        pubblication_date = []
        abstract = []
        journal_title = []
        coi = []
        doi = []
        authors = []
        keywords = []
        pubblication_type = []

        count = 1
        for UID in self.UIDs:
            data = self.get_data_UID(UID)

            title.append(self.get_title(data))
            pubblication_date.append(self.get_pubblication_date(data))
            abstract.append(self.get_abstract(data))
            journal_title.append(self.get_journal_title(data))
            coi.append(self.get_coi(data))
            doi.append(self.get_doi(data))
            authors.append(self.get_authors(data))
            keywords.append(self.get_keywords(data))
            pubblication_type.append(self.get_pubblication_type(data))

            progress_bar(count, len(self.UIDs))
            count += 1
        
        dict = {
            'PMID' : self.UIDs,
            'doi' : doi,
            'Title': title,
            'Pubblication Date' : pubblication_date,
            'Journal Title' : journal_title,
            'Authors' : authors,
            'Keywords' : keywords,
            'Abstract' : abstract,
            'Pubblication type' : pubblication_type,
            'Conflic Of Interests': coi,
        }

        return dict

    
    def get_pubblication_date(self, data):
        for tag in data:
            if tag[0] == 'DP':
                return tag[1]
    
    def get_title(self, data):
        for tag in data:
            if tag[0] == 'TI':
                return tag[1]
    
    def get_abstract(self, data):
        for tag in data:
            if tag[0] == 'AB':
                return tag[1]
    
    def get_journal_title(self, data):
        for tag in data:
            if tag[0] == 'JT':
                return tag[1]
                
    def get_coi(self, data):
        for tag in data:
            if tag[0] == 'COIS':
                return tag[1]
    
    def get_doi(self, data):
        for tag in data:
            if tag[0] == 'LID' and tag[1][-5:] == '[doi]':
                return tag[1][:-6]
    
    def get_authors(self, data):
        all_AU = ''
        for tag in data:
            if tag[0] == 'AU':
                all_AU = all_AU + tag[1] + ', '
        return all_AU[:-2]
    
    def get_keywords(self,data):
        all_keywords = ''
        for tag in data:
            if tag[0] == 'OT' or tag[0] == 'MH':
                all_keywords = all_keywords + tag[1] + ', '
        return all_keywords[:-2]
    
    def get_pubblication_type(self, data):
        all_attributes = ''
        for tag in data:
            if tag[0] == 'PT':
                all_attributes = all_attributes + tag[1] + ', '
        return all_attributes[:-2]