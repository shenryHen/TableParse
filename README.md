# TableParse
## Parses a psuedo-nested table and creates a new object from each field in a DataRow. 
### SQL Sever 2012 unfortunately cannot return nested tables when representing encapuslation (object A *has* some amount of object B). Sometimes this is imporant in OOP. What one can do is have certain rows represent the "bigger" object and each row represent the "smaller" objeet.


##Example:

| tree_id  | num_rings | anmal_id | species | age | socio_econ_status |
| ------------- |:-------------:| ---------:|---------|----------|-----------------|
| 1600 | 23 | 73 | 'rat' | 10 | .9 |
| 1600 | 23 | 12 | 'Squirrel' | 32 | .87 |
| 1600 | 23 | 53 | 'bat' | 15 | .5 |
| 420 | 901 | 42 | 'snake' | 72 | .88 |
| 420 | 901 | 97 | 'weed' | 32 | .33 |
| 9324 | 342 | 77 | 'bird' | 11 | .001 |
| 9324 | 342 | 76 | 'vole' | 1 | .55 |
| 9324 | 342 | 96 | 'kangaroo' | 69 | .60 |
| 9324 | 342 | 108 | 'Ginger Ale' | 20 | .17 |

1. Tree #1600 has
  * {73, 'rat', 10, .9}
  * {12, 'Squirrel', 32, .87}
  * {53, 'bat', 15, .5}
2. Tree #420 has 
  * {42, 'snake' | 72 | .8}
  * {97, 'weed' | 32 | .33}
3. Tree #9324 has
  * {77, 'bird', 11, .001}
  * {76, 'vole', 1, .55}
  * {96, 'kangaroo', 69, .60 }
  * {108, 'Ginger Ale', 20, .17}
