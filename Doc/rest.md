We can create `*.rest` files

> Currently in folder `rest`

#### Env config

Then we may add the configuration and set it in the
top menu when the rest file is opened

It allows us using variables

Ide stores it in `http-client.private.env.json`

```bash
{
  "dev": {
    "login": "someuser",
    "password": "somepass"
  }
}
```

And in `*.rest` file we may use it like

```bash
POST https://localhost:47262/api/v1/login
Cookie: somecookie
Content-Type: application/json

{
  "username": "{{login}}",
  "password": "{{password}}"
}
```

Ide preserves cookies between requests - so we can use requests chains

***

#### Good full example

```bash
### Login

POST https://localhost:47262/api/v1/login
Cookie: somecookie
Content-Type: application/json

{
  "username": "{{login}}",
  "password": "{{password}}"
}


### Get Colors

GET https://localhost:47262/api/v1/admin/colors?includeAll=true
Cookie: somecookie

# -- Some specific color

> {%
var foundElem = response.body.find(v => v.id === 2);
client.log(JSON.stringify(foundElem, null, 2));
 %}



```