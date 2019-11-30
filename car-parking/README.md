# Car parking problem

## Problem

There are many cars parked in the eTown parking lot. The parking is a straight, very long line and has a parking slot for every single meter. There are n cars parked currently and you want to cover them from the rain by building a roof. The requirement is that at least k cars are covered by the roof. What's the minimum length of the roof that would cover k cars?

## Input:
A file (input.txt) with 2 lines contains:
* First row (k): is the integer denoting the number of cars that have to be covered by the roof
* Second row (cars): integer array of length n denoting the parking slots where cars are parked

Example of the file:
```
3
2,10,8,17
```

## Expected output: a file at [output.txt](output.txt) contains the minimum length of the roof that would cover k cars

```
8
```
8 because it is the minumum length of the roof to cover the start and the end slots from: 2 -> 8 -> 10

## NOTES:
### run.sh must be modified to include all steps to build, compile and run your program to produce the desired output.txt
### Character encoding of the output file should be UTF-8
### Make sure to NOT include any "redundant spaces/lines" in the output.txt as an exact comparison is going to be used for evaluation
### Linux's newline character must be used when needed
