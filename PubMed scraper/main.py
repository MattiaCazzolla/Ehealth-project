import requests
import argparse
import time
import pandas as pd
from esearch import Esearch
from efetch import Efetch


if __name__ == '__main__':


    my_parser = argparse.ArgumentParser(
	    usage = "%(prog)s  'string' [options]",
	    description='PubMed API scraper that collects papers information and store them in a database')
    
    my_parser.add_argument('string',
                       type=str,
                       help='the string you would like to search on PubMed')
    
    group = my_parser.add_mutually_exclusive_group(required=False)
    group.add_argument('--quantity',
                        type=int,
                        metavar = '',
                        default=100000,
                        help='the number of papers you would like to retrieve, default 100000'
    )

    group.add_argument('--all',
                        action='store_true',
                        help='retrieve all the papers'
    )

    my_parser.add_argument('--format',
                        choices=['csv', 'json'],
                        default='csv',
                        help='define the database format, default csv'
    )

    args = my_parser.parse_args()
    
    search_string = args.string.replace(' ', '+')
    session = requests.Session()
    E = Esearch(session)

    if args.all:
        ls = E.get_uids(search_string, int(E.get_count(search_string)))
    else:
        ls = E.get_uids(search_string, args.quantity)

    time.sleep(2)

    fetch = Efetch(session, ls)
    df = fetch.get_data_UIDs()
    print('All papers info have been retrieved')

    pandas_df = pd.DataFrame(df)
    if args.format == 'csv':
        pandas_df.to_csv('database.csv', index=False)
    else:
        pandas_df.to_json('database.json')
    
    print('The database has been saved')