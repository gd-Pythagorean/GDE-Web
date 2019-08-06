express    = require 'express'
bodyParser = require 'body-parser'
cors       = require 'cors'
path       = require 'path'

app = express()

app.use bodyParser.urlencoded extended: false
app.use cors()

app.set 'views', path.join __dirname, 'views'

# Sets the render enging to EJS
app.set 'view engine', 'ejs'

app.get '/', (request, response) -> 
  response.render 'index'

app.listen 8000