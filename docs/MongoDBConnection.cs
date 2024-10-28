/*
Name: Ginny Ke
Date Created: 10/27/24
Date Revised: 10/27/24
Purpose: Establish connection between MongoDB database and project
*/

//All of this code was given by MongoDB when I created the database.
using MongoDB.Driver; // uses mongoDB driver
using MongoDB.Bson;

//connection string 
const string connectionUri = "mongodb+srv://21gke10:<Gk7856212727$>@eatmyfeats.p8ist.mongodb.net/?retryWrites=true&w=majority&appName=EatMyFeats";

//settings to connect 
var settings = MongoClientSettings.FromConnectionString(connectionUri);

// Set the ServerApi field of the settings object to set the version of the Stable API on the client
settings.ServerApi = new ServerApi(ServerApiVersion.V1);

// Create a new client and connect to the server
var client = new MongoClient(settings);

// Send a ping to confirm a successful connection
try {
  var result = client.GetDatabase("admin").RunCommand<BsonDocument>(new BsonDocument("ping", 1));
  Console.WriteLine("Pinged your deployment. You successfully connected to MongoDB!"); // prints if successful connection
} catch (Exception ex) { //cataches error if the connection is not succesful
  Console.WriteLine(ex);
}
