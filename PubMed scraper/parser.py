import argparse

def parser():
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
    return my_parser