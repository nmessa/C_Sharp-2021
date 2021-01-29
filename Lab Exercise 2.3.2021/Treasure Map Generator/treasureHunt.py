## treasureHunt.py
## Author: nmessa
## This program will hunt for treasure using a map

import random
#create a 2D matrix initialized to 0 using a list comprehension
map = [[0 for x in range(5)] for x in range(5)]

#open data file for reading
infile = open("map.dat", 'r')

#Fill the 2D array (Treasure Map) with clues
for row in range(5):
    for col in range(5):
        map[row][col] = int(infile.readline())
infile.close()

##Print out the map
for row in range(5):
    for col in range(5):
        print (map[row][col], end = ' ')
    print()

def searchForTreasure(row, col):
    #Get the clue from map location
    value = map[row-1][col-1]

    #Check if you have found the treasure
    if value == row*10 + col:
        s = "You have found the treasure at (" + str(row) + \
        ", " + str(col) + ")"
        print (s)
    #get next location to check
    else:
        #Calculate next row and col values
        row = value // 10
        col = value % 10

        #Print message of where you are going next
        s = "Going to location (" + str(row) + ", " + str(col) + ")"
        print (s)

        #Search for treasure at new location (recursive function call)
        searchForTreasure(row, col)

searchForTreasure(1,1)

##Output
##Going to location (3, 4)
##Going to location (4, 2)
##Going to location (1, 5)
##Going to location (2, 5)
##Going to location (3, 1)
##Going to location (5, 4)
##Going to location (1, 3)
##Going to location (3, 2)
##Going to location (4, 5)
##Going to location (3, 5)
##Going to location (2, 3)
##Going to location (4, 3)
##Going to location (5, 1)
##Going to location (2, 1)
##Going to location (1, 4)
##Going to location (4, 1)
##Going to location (3, 3)
##Going to location (5, 2)
##You have found the treasure at (5, 2)
