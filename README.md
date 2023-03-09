# C# Cellar API 

### An API to educate people about various wine regions

#### By Henry Sullivan

***

## Technologies Used

* C#
* .Net 6
* ASP.Net Core 6 MVC
* EF Core 6
* SQL
* MySQL
* LINQ
* Swagger

***

## Description

An API dedicated to educating people about various wine regions. Has room for development, but currently shows various wine regions designations as well as climate categorization and soil composition of said wine regions.

***

## Setup Installation Requirements

### Open project
1. Navigate to the `CSharpCellarApi` directory.
2. Create a file named `appsettings.json` with the following code, making sure to replace [YOUR-USERNAME-HERE] and [YOUR-PASSWORD-HERE] with your personal username and password respectively.
```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=cellar_api;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];",
  }
}
```
3. Install dependencies within the `CellarApi` directory
```
$ dotnet restore
```

4. To build & run program in development mode 
 ```
 $ dotnet run
 ```

5. To build & run program in production mode 
 ```
 dotnet run --launch-profile "production"
 ```
***

## API Documentation
### __Endpoints__
```
 GET http://localhost:5000/api/regions
 GET http://localhost:5000/api/regions/{id}
 ```
Note: The {id} value in the URL is a variable and should be replaced with the id number of the review the user wants to GET

*** 

### __GET Queries__
For GET http://localhost:5000/api/regions

Parameter   | Type  | Required | Description | 
|:---------|:---------:|:---------:|:---------|
appellation | string | Not Required | Returns regions with matching appellation value
country | string | Not Required | Returns regions with matching country value
climate | string | Not Required | Returns regions with matching climate value
soil | string | Not Required | Returns regions with matching soil value
id | int | Not Required | Returns regions with matching id value

### __Example GET Queries__

The following query will return all regions with the id value of 1:

``` GET http://localhost:7207/api/regions/1```

The following query will return all regions with the appellation value of "Bordeaux":

``` GET http://localhost:7207/api/regions?appellation=Bordeaux ```

The following query will return all regions with the country value of "Italy":

```GET http://localhost:7207/api/regions?country=Italy```

The following query will return all regions with the climate value of "hot":

```GET http://localhost:7207/api/regions?climate=hot```

The following query will return all regions with the soil value of "limestone":

```GET http://localhost:7207/api/regions?soil=limestone```

It's possible to include multiple query strings by separating them with an &:

``` GET http://localhost:7207/api/regions?category=restaurant&name=beso ```
***

## Known Bugs

* No known bugs. If you find one, please email me at  [sullivanbhenry@gmail.com](mailto:sullivanbhenry@gmail.com) and include:
  * BUG: _A brief description of the bug_
  * FIX: _Suggestion for solution (if you have one!)_
  * If you'd like to be credited, please also include your **_github user profile link_**

***

## License

MIT License

Copyright (c) 2023 Henry Sullivan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.