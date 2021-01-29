##Stardate Calculator
##Author: nmessa
##Date: 1.1.2020
##Modified 1.26.2020

from math import ceil
from datetime import date

def toStarDate(date):
    parts = date.split('/')
    month = int(parts[0])
    day = int(parts[1])
    year = int(parts[2])
    m = monthNumber[month]
    d = day
    n = 366
    y = year
    b = base1
    c = base2005
    if isLeapYear(year):
        m += 1
    sd = c + (1000 * (y-b)) + (1000/n * (m + d - 1))
    sd = round(sd, 2)
    return str(sd)

def isLeapYear(y):
    if y%4 == 0 and y%100 != 0 or y%400 ==0:
        return True
    else:
        return False
    
base1 = 2005
#base2 = 2323
base2005 = 58000
#base2323 = 0
monthNumber = {1:0, 2:31, 3:59, 4:90, 5:120, 6:151, 7:181, 8:212, 9:243,
               10:273, 11:304, 12:334, 13:365}

monthName = {1:"January", 2:"February", 3:"March", 4:"April", 5:"May",
             6:"June", 7:"July", 8:"August", 9:"September", 10:"October",
             11:"November", 12:"December"}

#Get date from system clock and convert to string
myDate = str(date.today())

#Break apart date into year, month, day
temp = myDate.split('-')

#Rebuild myDate into correct format for toStarDate function
myDate = temp[1] + "/" + temp[2] + "/" + temp[0]

#Convert date to stardate
starDate = toStarDate(myDate)

#Print the results
print("Stardate for " + myDate + " is " + starDate)



