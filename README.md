# TableParse
## Parses a psuedo-nested table and creates a new object from each field in a DataRow. 
### SQL Sever 2012 unfortunately cannot return nested tables when representing encapuslation (object A *has* some amount of object B). Sometimes this is imporant in OOP. What one can do is have certain rows represent the "bigger" object and each row represent the "smaller" objeet.


##Example:

| tree_id  | num_rings | anmal_id | species | age | socio_econ_status |
| ------------- |:-------------:| ---------:|---------|----------|-----------------|
| 1600 | 23 | 73 | 'rat' | 10 | .9 |
| 1600 | 23 | 73 | 'Squirrel' | 32 | .87 |
| 1600 | 23 | 73 | 'Bird' | 8 | .1 |
| 1600 | 23 | 73 | 'bat' | 15 | .5 |
| 420 | 901 | 32 | 'snake' | 72 | .88 |
| 420 | 901 | 32 | 'lion' | 32 | .33 |
| 9324 | 342 | 88 | 'bird' | 11 | .001 |
| 9324 | 342 | 88 | 'vole' | 1 | .55 |
| 9324 | 342 | 88 | 'kangaroo' | 69 | .60 |
| 9324 | 342 | 88 | 'Ginger Ale' | 20 | .17 |

