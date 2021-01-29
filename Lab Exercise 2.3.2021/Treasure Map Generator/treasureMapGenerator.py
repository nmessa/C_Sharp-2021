## treasureMapGenerator.py
## Author: nmessa
## This program will generate a treasure map

import random

def generateTreasureMap(row, col):
    #Get clue
    value = 0
    while map[row-1][col-1] == 0:
        newRow = random.randint(1, 5)
        newCol = random.randint(1, 5)
        value = newRow * 10 + newCol
        map[row-1][col-1] = value
        clues.append(value)

    #Check if you have found the treasure
    if value == row*10 + col:
        s = "Treasure map generation complete"
        print (s)
        return
    #get next location to check
    else:
        #Calculate next row and col values
        row = value // 10
        col = value % 10

        #Search for treasure at new location (recursive function call)
        generateTreasureMap(row, col)

def fillValues():
    value = 0
    for row in range(5):
        for col in range(5):
            if map[row][col] == 0:
                while value in clues:
                    value =  random.randint(1,5)* 10 + random.randint(1,5)
                map[row][col] = value
    
#create a 2D matrix initialized to 0 using a list comprehension
map = [[0 for x in range(5)] for x in range(5)]

clues = []
#Fill the 2D array (Treasure Map) 0
for row in range(5):
    for col in range(5):
        map[row][col] = 0

##Print out the map
for row in range(5):
    for col in range(5):
        print (map[row][col], end = ' ')
    print()

generateTreasureMap(1,1)

fillValues()

##Print out the map
for row in range(5):
    for col in range(5):
        print (map[row][col], end = ' ')
    print()


#open data file for writing
outfile = open("map3.dat", 'w')

#Fill the 2D array (Treasure Map) with clues
for row in range(5):
    for col in range(5):
         outfile.write(str(map[row][col]) + '\n')
outfile.close()


