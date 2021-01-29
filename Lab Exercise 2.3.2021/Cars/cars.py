#Closest approach of 2 cars
##Car1 traveling north currently 2 miles south of junction at a rate of 30 MPH
##Car2 traveling west currently 3 miles east of jucntion at a rate of 40 MPH
##Find the closest distance the two cars approach

from math import *
from pylab import *
import time
times = []
distances = []
t = 0

while True:
    car1 = 2 - 30/3600 * t
    car2 = 3 - 40/3600 * t
    distance = sqrt(car1**2 + car2**2)
    if car1 < 0 and car2 < 0:
        break
    #print(car1, car2, distance)
    distances.append(distance)
    times.append(t)
    t += 1
    
plot(times, distances)
grid(True)
show()
