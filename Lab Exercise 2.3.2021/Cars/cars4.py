#At what speeds do cars collide?
##Car1 traveling north currently 2 miles south of junction
##Car2 traveling west currently 3 miles east of jucntion
#This is a refined version based up results from the previous problem
#A collision occurs if distance between cars gets to 0.001 miles
#Car 1 has a speed range of 25.0 to 35.0 MPH in 0.1 increments
#Car 2 has a speed range of 35.0 to 55.0 MPH in 0.1 increments

from math import *
from pylab import *
import time

collisions = []
for speed1 in range(250, 350):
    for speed2 in range(350,550):
        times = []
        distances = []
        t = 0
        while True:
            car1 = 2 - speed1/10/3600 * t
            car2 = 3 - speed2/10/3600 * t
            distance = sqrt(car1**2 + car2**2)
            if car1 < 0 and car2 < 0:
                break
            distances.append(distance)
            times.append(t)
            t += 1
        if distance < 0.001:
            collisions.append((speed1/10, speed2/10))
##            plot(times, distances)
##            grid(True)
##            show()
print(collisions)
##Solution
#[(27.8, 41.7)]
