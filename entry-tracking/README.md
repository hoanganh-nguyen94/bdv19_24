# Entry tracking

## Problem

The security department need to manage the entry and exit status of each person by analyse the logs information. For each person’s entry or exit, print the name of the person, followed by entered or exited. If the action is anomalous, print (ANOMALY) afterward. Each line describing either an entry or exit by an employee. Each description is of the form ‘entry name’ or ‘exit name’, where name is a string of up to 20 uppercase and/or lowercase characters (a-z).

## Input:
A file (input.txt) with n lines contains:

* First row: is the integer number 1 ≤ n ≤ 100, denoting the number of the line to be read
* The rest rows: the logs of entry and exit records data
* Entry logs data format is ‘entry’ or ‘exit’ + ‘person name’

Example of the file:
```
8
entry Hung
entry Hung
exit Hung
entry Phong
exit Khoa
entry Hoang
exit Van
entry Anh
```

## Expected output: a file at [output.txt](output.txt) contains entry/exit status of each person

```
Hung entered
Hung entered (ANOMALY)
Hung exited
Phong entered
Khoa exited (ANOMALY)
Hoang entered
Van exited (ANOMALY)
Anh entered
```
## NOTES:
### run.sh must be modified to include all steps to build, compile and run your program to produce the desired output.txt
### Character encoding of the output file should be UTF-8
### Make sure to NOT include any "redundant spaces/lines" in the output.txt as an exact comparison is going to be used for evaluation
### Linux's newline character must be used when needed
