# TableParse
## Parses a psuedo-nested table and creates a new object from each field in a DataRow. 
### SQL Sever 2012 unfortunately cannot return nested tables when representing encapuslation (object A *has* some amount of object B). Sometimes this is imporant in OOP. What one can do is have certain rows represent the "bigger" object and each row represent the "smaller" objeet.


##Example:

| tree_id  | num_rings | anmal_id | species | age | socio_econ_status |
| ------------- |:-------------:| -----:|
| 1600 | 23 | 73 | 'rat' | 10 | .9 |
| 1600 | 12 | 10 | 'Squirrel' | 32 | .87 |
| 1600 | 13 | 42 | 'Squirrel' | 8 | .1 |
| 1600 | 104 | 76 | 'bat' | 15 | .5 |
| 420 | 901 | 32 | 'snake' | 72 | .88 |
| 420 | 502 | 22 | 'snake' | 32 | .33 |
| 9324 | 342 | 88 | 'rat' | 28 | .001 |

