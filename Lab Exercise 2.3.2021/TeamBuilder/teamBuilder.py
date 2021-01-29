#Lab Exercise 12/5/2017 Problem 1
#Author: nmessa

from random import *

#Create a lists to hold the names and teams
names = []
teams = []

#read in the names
infile = open("namesAM.txt", 'r')
nameList = infile.readlines()
infile.close()

#Strip off the newline characters
for name in nameList:
    names.append(name.rstrip())

#Print a class list
for name in names:
    print(name)

#Remove absent students
answer = input("Are there any absent students? (y/n) ")
if answer == 'y':
    num = int(input("How many? "))
    for i in range(num):
        name = input("Enter the student name: ")
        names.remove(name)
    
#Create a list for each team
numTeams = int(input("How many teams? "))
for i in range(numTeams):
    teams.append([])

#Pick the teams
count = 0
while len(names) > 0:
    name = choice(names)
    teams[count%numTeams].append(name)
    names.remove(name)
    count += 1

#Print the teams
for team in teams:
    print(team)
    
    






