#!/bin/python3

import math
import os
import random
import re
import sys
from collections import Counter

# Complete the repeatedString function below.


def repeatedString(s, n):
    if s == "a":
        return n

    new = s

    while len(new) < n:
        new += s

    c = Counter(new[:n])
    k = c['a']
    return k


if __name__ == '__main__':
    # fptr = open(os.environ['OUTPUT_PATH'], 'w')

    s = input()

    n = int(input())

    result = repeatedString(s, n)

    # fptr.write(str(result) + '\n')

    # fptr.close()
    print(result)