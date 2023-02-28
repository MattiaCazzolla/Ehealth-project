# E-health Methods and Applications Project
Project of the course 'E-health methods and applications' @ Politecnico di Milano <br>
- ####  Mattia Cazzolla  ([@MattiaCazzolla](https://github.com/MattiaCazzolla)) mattia.cazzolla@mail.polimi.it
- ####  Emma Lacagnina ([@EmmaLacagnina](https://github.com/EmmaLacagnina)) emma.lacagnina@mail.polimi.it
- ####  Giorgia Maimone ([@GiorgiaMaimone](https://github.com/GiorgiaMaimone)) giorgia.maimone@mail.polimi.it
Final grade: 14/15

# Part 1: PubMed Scraper
In the first part of the project we had to develop a *PubMed* scraper able to collect generic information from papers originated from a user search. <br>

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

# Part 2: Serious game
In the second part of the project we had to develop a serious game, aimed at children with ADHD, consisting of a gamification of the [Stroop Test](https://en.wikipedia.org/wiki/Stroop_effect)

<p align=center>
<img src="/imgs/title.png" alt="">
</p>

## License
This project is licensed under the [MIT](LICENSE) License.
