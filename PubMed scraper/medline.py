def medline_formatting(medline_string):
    medline_list = medline_string.split('\n')

    ls = []

    for elem in medline_list:
        if elem == '':
            continue
        elif elem[0:4] != '    ':
            elem = elem.strip()
            elem = elem.replace('\n', '')
            ls.append(elem)
        else:
            elem = elem.strip()
            elem = elem.replace('\n', '')
            ls[-1] = ls[-1] + elem
    
    ls_2 = [] 
    for elem in ls:
        key = elem[0:4].strip()
        value = elem[5:].strip()
        
        ls_2.append([key, value])

    
    return ls_2