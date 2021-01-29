#At what speeds do cars collide?
##Car1 traveling north currently 2 miles south of junction
##Car2 traveling west currently 3 miles east of jucntion
#Car speeds range from 25 to 60 MPH
#A collision occurs if distance between cars gets to 0.01 miles

from math import *
from pylab import *
import time

collisions = []
for speed1 in range(25, 61):
    for speed2 in range(25,61):
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
##[(26, 39), (34, 51)]
