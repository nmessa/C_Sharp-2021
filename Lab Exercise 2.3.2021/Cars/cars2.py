#Closest approach of 2 cars
##Car1 traveling north currently 2 miles south of junction at a rate of 30 MPH
##Car2 traveling west currently 3 miles east of jucntion at a rate of 40 MPH
##Find the closest distance the two cars approach

from math import *
from pylab import *
import time

collisions = []
for speed1 in range(1, 50):
    for speed2 in range(1,50):
        times = []
        distances = []
        t = 0
        while True:
            car1 = 2 - speed1/3600 * t
            car2 = 3 - speed2/3600 * t
            distance = sqrt(car1**2 + car2**2)
            if car1 < 0 and car2 < 0:
                break
            distances.append(distance)
            times.append(t)
            t += 1
        if distance < 0.01:
            collisions.append((speed1, speed2))
##            plot(times, distances)
##            grid(True)
##            show()
print(collisions)
##Solution
##0.2 miles at time 259 seconds
