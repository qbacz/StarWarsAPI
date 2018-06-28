# SWAPI Integration

Use this API to get STAR WARS charaters  
Under the hood it uses SWAPI (more info -> https://swapi.co/documentation)

## Getting Started

Build the project and set the dependencies if necessary.  
Build and start StarWarsAPI project and it's ready for receiving requests.

```
REQUEST
GET {host}/characters?nameContains=luke 

RESPONSE
[
    {
        "name": "Luke Skywalker"
    }
]
```
  
```
REQUEST
GET {host}/characters?nameContains=ar

RESPONSE
[
    {
        "name": "Darth Vader"
    },
    {
        "name": "Owen Lars"
    },
    {
        "name": "Beru Whitesun lars"
    },
    {
        "name": "Biggs Darklighter"
    },
    {
        "name": "Wilhuff Tarkin"
    },
    {
        "name": "Ackbar"
    },
    {
        "name": "Arvel Crynyd"
    },
    {
        "name": "Wicket Systri Warrick"
    },
    {
        "name": "Jar Jar Binks"
    },
    {
        "name": "Roos Tarpals"
    },
    {
        "name": "Quarsh Panaka"
    },
    {
        "name": "Darth Maul"
    },
    {
        "name": "Ben Quadinaros"
    },
    {
        "name": "Yarael Poof"
    },
    {
        "name": "Gregar Typho"
    },
    {
        "name": "Cliegg Lars"
    },
    {
        "name": "Luminara Unduli"
    },
    {
        "name": "Barriss Offee"
    },
    {
        "name": "Tarfful"
    }
]