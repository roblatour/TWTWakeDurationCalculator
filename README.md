# TWTWakeDurationCalculator (for Windows)

open-source by Rob Latour, 2023, MIT license

# Background

I needed to find the best possible Wi-Fi 6 Targeted Wake Time Duration mantissa and exponent to use for an esp32 open source Weather Station I was working on.

However, not being able to find an online calculator for it, I wrote this (Windows .net) program to do the job.

All you need to do to is enter in the desired wake time duration and it will 'calculate' (brute force determine) the best possible mantissa and exponent. 

In some cases, for example for a one second wake duration, the program will calculate an exact match for the mantissa and exponent.  In other cases, where an exact match is not possible, the program will calculate the best possible alternatives (one a little low, and one a little high).

The Wi-Fi 6 Targeted Wake Time Duration formula described here https://ieeexplore.ieee.org/stamp/stamp.jsp?arnumber=9481882 as TWT = mantissa * 2^exponent.

# Screenshots

![components](https://github.com/roblatour/TWTWakeDurationCalculator/blob/main/screenshot1.jpg)
![components](https://github.com/roblatour/TWTWakeDurationCalculator/blob/main/screenshot2.jpg)


# Code and executable

Within this repo you will find:
- the files - including the digially signed (by me) exexcutable and dll files - needed to run the program on a Windows 11 computer, and 
- the visual studio source code for the same should you wish to build them yourself
