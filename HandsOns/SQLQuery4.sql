SELECT CONCAT ( 'Happy ', 'Birthday ', 11, '/', '25' ) AS Result;

-- Returns a DIFFERENCE value of 4, the least possible difference.  
SELECT SOUNDEX('Green'), SOUNDEX('Greene'), DIFFERENCE('Green','Greene');  
 
-- Returns a DIFFERENCE value of 0, the highest possible difference.  
SELECT SOUNDEX('Blotchet-Halls'), SOUNDEX('Greene'), DIFFERENCE('Blotchet-Halls', 'Greene');  

select DIFFERENCE('apple','applied')

--Formatting numeric values by specifying a custom format
DECLARE @d DATE = GETDATE();  
SELECT FORMAT( @d, 'dd/MM/yyyy', 'en-US' ) AS 'Date' , 
      FORMAT(123456789,'###-##-####') AS 'Custom Number';

--Return the two leftmost characters of the character string
SELECT LEFT('Meghna',2);  

SELECT LEN( 'Hello Worls' ) AS Length

SELECT LOWER ( 'MEGHNA' )

SELECT UPPER ( 'riya' )

SELECT LTRIM ( '    Hello' ) as LeftTrim

SELECT RTRIM ( 'Hello    ' ) as RightTrim

DECLARE @nstring NCHAR(8);  
SET @nstring = N'København';  
SELECT UNICODE(SUBSTRING(@nstring, 2, 1)),   
   NCHAR(UNICODE(SUBSTRING(@nstring, 2, 1)));  

SELECT position = PATINDEX('%orn%', 'Good Morning');

SELECT REPLACE('Meghna','na','xx'); 

SELECT REPLICATE('0', 4)

SELECT REVERSE ( 'meghna' ) 

SELECT RIGHT ( 'Meghna' , 3 )

-- Using SOUNDEX  
SELECT SOUNDEX ('Meghna'), SOUNDEX ('Megha');  

SELECT 'Meghna' + SPACE(2)+'Sarkar'

SELECT STR(123.45, 6, 1); 
SELECT STR(123.45, 2, 2); 

SELECT STUFF('abcdef', 2, 3, 'ijklmn'); 

SELECT SUBSTRING('Meghna', 1, 1) AS Initial



