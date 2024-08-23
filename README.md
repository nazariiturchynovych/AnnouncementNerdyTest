[AnnouncementEndpoints.postman_collection.json](https://github.com/user-attachments/files/16730535/AnnouncementEndpoints.postman_collection.json)This is test project for NerdySoft trainee position,

You can see that this project has small amount of commits, its my second time i create it, because first time i made mistake with gitignore file and added some files that will crush app if ypu will copy it from git, so i decided to create it second time, to see my previous commit please visit this project https://github.com/nazariiturchynovych/AnnouncementNerdy, it was my firs attempt

In this project i used: 
- Clean Architectore,
- SQRS pattern with Mediatr,
- FluentValidation for request validation,
- ElasticSearch as main db for entites (mainly used because find similar feature, which can be easily implemented in elastic search, and beacause Announcement entity is mostly consist text, so with ES is easier to search and index words etc.). Also i thought about using Postgres as my db, but find similar would be not that great if use LINQ, also i thought abot using 2 db's like ES and postgre and share between them data to use benefits from both, but it would be too complicated for this size of project,
- Kibana as ES UI,
- Serilog with Seq to store logs,
- XUnit, Moq, FluentAssertion for unit testing Application layer, i understand that it would be better to implement integration test for elastic serach but it is at it is,
- bogus to seed data

To run this project, simply use docker-compose. The project consists of five images. The composition time typically takes about 1 to 1.5 minutes, in my case. Please wait until Kibana starts and establishes a connection before proceeding.
- elastic
- kibana
- elastic_setup - for settuping elastic search, its certificates and parsing them to kibana,
- seq,
- announcement - API

To use kibana go to localhost:5601
- login: elastic
- password: ElasticPassword
- Go where arrow is pointing and click discower, when announcement will be created it will be shown here
<img width="1440" alt="image" src="https://github.com/user-attachments/assets/1de977b7-e962-4a57-9169-f1c490cfaf6b">

- Seq is running here: http://localhost:8081

- Postman Endpoints
[AnnouncementEndpoints.postman_collection.json](https://github.com/user-attachments/files/16730540/AnnouncementEndpoints.postman_collection.json)
