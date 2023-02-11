# SQL Assignment 

### Show only inactive widgets
````
SELECT *
FROM Widgets
WHERE active = 0;
````

### Show only widgets that start with “Demo”
````
SELECT *
FROM Widgets
WHERE Widget LIKE 'Demo%';
````

### Show only widgets that have “Registration” in their name
````
SELECT *
FROM Widgets
WHERE Widget LIKE '%Registration%';
````

### Show all languages that the site “https://www.fxlider.com” has
````
SELECT Lang
FROM Widgets
WHERE SiteName = 'https://www.fxlider.com';
````

### How many languages are there in each site? Please show a list of websites and the number of languages per each site.
````
SELECT COUNT(Lang), SiteName
FROM Widgets
GROUP BY SiteName
````