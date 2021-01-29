##Stardate Calculator
##Author: nmessa
##Date: 1.1.2020


from math import ceil

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
    
def toGregorianDate(date):
    year = int(date)//1000
    year *= 1000
    year -= base2005
    year //= 1000
    year += base1
    month = (int(date)//1000)*1000
    month = round(date - month,2)
    if isLeapYear(year):
        month *= 366
    else:
        month *= 365
    month /= 1000
    month = ceil(month)
    month += 1
    if isLeapYear(year):
        for m in range(3, 14):
            monthNumber[m] += 1
        month -= 1
    for m in range(1, 14):
        if month <= monthNumber[m]:
            mName = monthName[m-1]
            day = month - monthNumber[m-1]
            break
    
    return mName + " " + str(day) + ", " + str(year)
    
base1 = 2005
#base2 = 2323
base2005 = 58000
#base2323 = 0
monthNumber = {1:0, 2:31, 3:59, 4:90, 5:120, 6:151, 7:181, 8:212, 9:243,
               10:273, 11:304, 12:334, 13:365}

monthName = {1:"January", 2:"February", 3:"March", 4:"April", 5:"May",
             6:"June", 7:"July", 8:"August", 9:"September", 10:"October",
             11:"November", 12:"December"}

myDate = input("Enter the date (mm/dd/yyyy): ")
starDate = toStarDate(myDate)
print("Stardate for " + myDate + " is " + starDate)

myDate = float(input("Enter the stardate (xxxxxx.xx): "))
gregDate = toGregorianDate(myDate)
print("Gregorian date for " + str(myDate) + " is " + gregDate)

##Sample Output
##Enter the date (mm/dd/yyyy): 9/8/1952
##Stardate for 9/8/1952 is 5685.79
##Enter the stardate (xxxxxx.xx): 5685.79
##252
##Gregorian date for 5685.79 is September 8, 1952

