The following design principles used while implementing the premium calculation service.
1.	Clean architecture followed in implementing API module with API component, Model and service layer.
2.	Service  calculator has been injected to API end point.
3.	Creation pattern used to initiate all builder objects required.
4.	Angular component will consume API end point. UI implemented with following validations
i.	Amount value should be positive.
     ii.	all feilds are mandatory , form will be validated.
     iii.	Age calculated based on the date picker. It will be in years.
5.	Unit testing added with xunit which will unit test all the service end points and services.

PS: inline validations are used and also styles can be seperated to css file.

![image](https://user-images.githubusercontent.com/58421595/173562427-2faeb074-9f33-4edf-8dea-0e5b55b753ec.png)

