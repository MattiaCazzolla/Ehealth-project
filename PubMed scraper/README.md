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
usage: main.py "string" [options]

PubMed API scraper that collects papers information and store them in a database

positional arguments:
  string               the string you would like to search (ideally keywords)

options:
  -h, --help           show this help message and exit
  --quantity           the number of papers you would like to retrieve, default 1000
  --all                retrieve all the papers
  --format {csv,json}  define the database format, default csv
  --score              compute relevance score for each paper
```
Here an example:
```bash
python main.py "cnn lung cancer" --quantity 200 --score
```
The database is saved in the current folder:
```text
.
├── database.json
```
## License
This project is licensed under the [MIT](LICENSE) License.
