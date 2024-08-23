This is test project for NerdySoft trainee position,

You can see thta this project has small amount of commits, its my second time i create it, because first time i made mistake with gitignore file and added some files that will crush app if ypu will copy it from git, so i decided to create it second time, to see my previous commit please visit this project https://github.com/nazariiturchynovych/AnnouncementNerdy, it was my firs attempt

In this project i used: 
- Clean Architectore,
- SQRS pattern with Mediatr,
- FluentValidation for request validation,
- ElasticSearch as main db for entites (mainly used because find similar feature, which can be easily implemented in elastic search, and beacause Announcement entity is mostly consist text, so with ES is easier to search and index words etc.). Also i thought about using Postgres as my db, but find similar would be not that great if use LINQ, also i thought abot using 2 db's like ES and postgre and share between them data to use benefits from both, but it would be too complicated for this size of project,
- Kibana as ES UI,
- Serilog with Seq to store logs,
- XUnit, Moq, FluentAssertion for unit testing Application layer, i understand that it would be better to implement integration test for elastic serach but it is at it is,

To run this project just use docker-compose, it has 5 images:
- elastic
- kibana
- elastic_setup - for settuping elastic search, its certificates and parsing them to kibana,
- seq,
- announcement - API

To use kibana go to localhost:5601
login: elastic
password: ElasticPassword
Go where arrow is pointing and click discower, when announcement will be created it will be shown here
<img width="1440" alt="image" src="https://github.com/user-attachments/assets/1de977b7-e962-4a57-9169-f1c490cfaf6b">

Seq is running here: http://localhost:8081

Postman Endpoints
[AnnouncementEndpoints.postman_collection.json](https://github.com/user-attachments/files/16730127/AnnouncementEndpoints.postman_collection.json){
	"info": {
		"_postman_id": "627e7a94-490e-4f61-a140-0a63e697f7b3",
		"name": "AnnouncementEndpoints",
		"schema": "https://schema.getpostman.com/json/collection/v2.1.0/collection.json",
		"_exporter_id": "27921412"
	},
	"item": [
		{
			"name": "GetById",
			"event": [
				{
					"listen": "test",
					"script": {
						"exec": [
							"pm.test(\"Status code is 200\", function () {",
							"    pm.response.to.have.status(200);",
							"});"
						],
						"type": "text/javascript"
					}
				}
			],
			"request": {
				"method": "GET",
				"header": [],
				"url": {
					"raw": "{{base_url}}/info?id=1",
					"host": [
						"{{base_url}}"
					],
					"path": [
						"info"
					],
					"query": [
						{
							"key": "id",
							"value": "1"
						}
					]
				},
				"description": "This is a GET request and it is used to \"get\" data from an endpoint. There is no request body for a GET request, but you can use query parameters to help specify the resource you want data on (e.g., in this request, we have `id=1`).\n\nA successful GET response will have a `200 OK` status, and should include some kind of response body - for example, HTML web content or JSON data."
			},
			"response": []
		},
		{
			"name": "GetAnnouncementList",
			"event": [
				{
					"listen": "test",
					"script": {
						"exec": [
							"pm.test(\"Status code is 200\", function () {",
							"    pm.response.to.have.status(200);",
							"});"
						],
						"type": "text/javascript"
					}
				}
			],
			"request": {
				"method": "GET",
				"header": [],
				"url": {
					"raw": "{{base_url}}/info?id=1",
					"host": [
						"{{base_url}}"
					],
					"path": [
						"info"
					],
					"query": [
						{
							"key": "id",
							"value": "1"
						}
					]
				},
				"description": "This is a GET request and it is used to \"get\" data from an endpoint. There is no request body for a GET request, but you can use query parameters to help specify the resource you want data on (e.g., in this request, we have `id=1`).\n\nA successful GET response will have a `200 OK` status, and should include some kind of response body - for example, HTML web content or JSON data."
			},
			"response": []
		},
		{
			"name": "GetSimmilarAnnouncements",
			"event": [
				{
					"listen": "test",
					"script": {
						"exec": [
							"pm.test(\"Status code is 200\", function () {",
							"    pm.response.to.have.status(200);",
							"});"
						],
						"type": "text/javascript"
					}
				}
			],
			"request": {
				"method": "GET",
				"header": [],
				"url": {
					"raw": "{{base_url}}/info?id=1",
					"host": [
						"{{base_url}}"
					],
					"path": [
						"info"
					],
					"query": [
						{
							"key": "id",
							"value": "1"
						}
					]
				},
				"description": "This is a GET request and it is used to \"get\" data from an endpoint. There is no request body for a GET request, but you can use query parameters to help specify the resource you want data on (e.g., in this request, we have `id=1`).\n\nA successful GET response will have a `200 OK` status, and should include some kind of response body - for example, HTML web content or JSON data."
			},
			"response": []
		},
		{
			"name": "Post data",
			"event": [
				{
					"listen": "test",
					"script": {
						"exec": [
							"pm.test(\"Successful POST request\", function () {",
							"    pm.expect(pm.response.code).to.be.oneOf([200, 201]);",
							"});",
							""
						],
						"type": "text/javascript"
					}
				}
			],
			"request": {
				"method": "POST",
				"header": [],
				"body": {
					"mode": "raw",
					"raw": "{\n\t\"name\": \"Add your name in the body\"\n}",
					"options": {
						"raw": {
							"language": "json"
						}
					}
				},
				"url": {
					"raw": "{{base_url}}/info",
					"host": [
						"{{base_url}}"
					],
					"path": [
						"info"
					]
				},
				"description": "This is a POST request, submitting data to an API via the request body. This request submits JSON data, and the data is reflected in the response.\n\nA successful POST request typically returns a `200 OK` or `201 Created` response code."
			},
			"response": []
		},
		{
			"name": "Update data",
			"event": [
				{
					"listen": "test",
					"script": {
						"exec": [
							"pm.test(\"Successful PUT request\", function () {",
							"    pm.expect(pm.response.code).to.be.oneOf([200, 201, 204]);",
							"});",
							""
						],
						"type": "text/javascript"
					}
				}
			],
			"request": {
				"method": "PUT",
				"header": [],
				"body": {
					"mode": "raw",
					"raw": "{\n\t\"name\": \"Add your name in the body\"\n}",
					"options": {
						"raw": {
							"language": "json"
						}
					}
				},
				"url": {
					"raw": "{{base_url}}/info?id=1",
					"host": [
						"{{base_url}}"
					],
					"path": [
						"info"
					],
					"query": [
						{
							"key": "id",
							"value": "1"
						}
					]
				},
				"description": "This is a PUT request and it is used to overwrite an existing piece of data. For instance, after you create an entity with a POST request, you may want to modify that later. You can do that using a PUT request. You typically identify the entity being updated by including an identifier in the URL (eg. `id=1`).\n\nA successful PUT request typically returns a `200 OK`, `201 Created`, or `204 No Content` response code."
			},
			"response": []
		},
		{
			"name": "Delete data",
			"event": [
				{
					"listen": "test",
					"script": {
						"exec": [
							"pm.test(\"Successful DELETE request\", function () {",
							"    pm.expect(pm.response.code).to.be.oneOf([200, 202, 204]);",
							"});",
							""
						],
						"type": "text/javascript"
					}
				}
			],
			"request": {
				"method": "DELETE",
				"header": [],
				"body": {
					"mode": "raw",
					"raw": "",
					"options": {
						"raw": {
							"language": "json"
						}
					}
				},
				"url": {
					"raw": "{{base_url}}/info?id=1",
					"host": [
						"{{base_url}}"
					],
					"path": [
						"info"
					],
					"query": [
						{
							"key": "id",
							"value": "1"
						}
					]
				},
				"description": "This is a DELETE request, and it is used to delete data that was previously created via a POST request. You typically identify the entity being updated by including an identifier in the URL (eg. `id=1`).\n\nA successful DELETE request typically returns a `200 OK`, `202 Accepted`, or `204 No Content` response code."
			},
			"response": []
		}
	],
	"event": [
		{
			"listen": "prerequest",
			"script": {
				"type": "text/javascript",
				"exec": [
					""
				]
			}
		},
		{
			"listen": "test",
			"script": {
				"type": "text/javascript",
				"exec": [
					""
				]
			}
		}
	],
	"variable": [
		{
			"key": "base_url",
			"value": "http://localhost:6003/api/Announcements"
		}
	]
}


