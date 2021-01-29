## treasureMapGenerator.py
## Author: nmessa
## This program will generate a treasure map

from random import choice

def generateTreasureMap():
    #define a list of possible map locations
    mapList = [11, 12, 13, 14, 15, 21, 22, 23, 24, 25, 31, 32, 33, 34, 35,
               41, 42, 43, 44, 45, 51, 52, 53, 54, 55]

    #define treasure location
    treasure = choice(mapList)
    mapList.remove(treasure)
    map[treasure//10 - 1][treasure%10 -1] = treasure

    for row in range(5):
        for col in range(5):
            if map[row][col] == 0:
                clue = choice(mapList)
                map[row][col] = clue
                mapList.remove(clue)

    
#create a 2D matrix initialized to 0 using a list comprehension
map = [[0 for x in range(5)] for x in range(5)]

#Fill the 2D array (Treasure Map) 0
for row in range(5):
    for col in range(5):
        map[row][col] = 0

##Print out the map
##for row in range(5):
##    for col in range(5):
##        print (map[row][col], end = ' ')
##    print()

generateTreasureMap()


##Print out the map
for row in range(5):
    for col in range(5):
        print (map[row][col], end = ' ')
    print()


#open data file for writing
outfile = open("map.dat", 'w')

#Fill the 2D array (Treasure Map) with clues
for row in range(5):
    for col in range(5):
         outfile.write(str(map[row][col]) + '\n')
outfile.close()


