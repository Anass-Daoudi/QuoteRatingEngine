# Coterie Insure Backend Take-Home Project Solution

## Context

In this project, I've architected and developed a solution, a Web API, for the [Coterie Insure Backend Take-Home Project](https://github.com/CoterieInsure/backend-takehome#readme)

## What I've completed as mandatory tasks

- [x] API written in .NET Core
- [x] API accepts POST and returns data per requirements
- [x] Repo README has instructions for running and testing the API
- [x] Repo README has information about what I'd do next, per requirements
- [x] Create a new GitHub repo

## What I've completed as a plus from my side

- [x] I've used Clean Architecture to better architect the API, so every part of it could scale easily and independently from the other ones
- [x] I've unit and e2e tested every layer of the API

## How to run the API

1. Clone this repository
2. Open the QuoteRatingEngine folder using Visual Studio Code
3. In the upper menu of the editor, you should see a Run tab, click on it
4. And click on Run Without Debugging
5. You can now consume the API using a tool like Postman

## How to consume the API

After running the API, send a POST request to the link https://localhost:5001/api/quoteratingengine/computepremium with the correct request body. The below image show my personal test using Postman:

![Postman Post Request Test](./assets/postman-post-request-test.png)

## How to unit and e2e test the API

1. Clone this repository
2. Open the QuoteRatingEngine folder using Visual Studio Code
3. Open the built in Visual Studio Code terminal
4. You should run this command `dotnet test` inside the QuoteRatingEngine folder

## What I would do next

- Add data validation layer
- Add Swagger for documentation and API testing
- Cash premium result so it is not recomputed for same inputs in other requests. I can use Redis for this optimization purpose
- Store data, states with state factors, business with business factors, hazard factor in a database, so they could be updated independently from changing the API
- Add controllers to manipulate data like state, state factor...
- Add controllers so client of the API could know available states and businesses in order to make a valid request body input
- Add Roles to only permit admins to manipulate data like state, state factor and permit a user role to compute premium
- Add CI and CD workflows to better industrialize the API building, testing, packaging and deployment
- Add versioning of the API so to update API without breaking changes
- Add integration test for the QuoteRatingEngineController controller
- Add logging service so to help on investigation and give insights and metrics about CPU, memory and storage consumptions...
- Customize exception handling
