# PubMed Scraper

Python program able, given a search term, to scrape PubMed API and to collect generic information about each result

## Installation
Clone this repository
```bash
git clone https://github.com/MattiaCazzolla/ehealth-project.git
```

## Requirements
```bash
pip install requests
pip install pandas
```

## Usage
```text
usage: main.py  'string' [options]

PubMed API scraper that collects papers information and store them in a database

positional arguments:
  string               the string you would like to search on PubMed

options:
  -h, --help           show this help message and exit
  --number             the number of papers you would like to retrieve, default 100000
  --all                retrieve all the papers
  --format {csv,json}  define the database format, default csv
```
Here an example:
```bash
python main.py 'machine learning' --number 200 --format json
```
The database is saved in the current folder:
```text
.
├── database.json
```
## License
This project is licensed under the [MIT](LICENSE) License.
