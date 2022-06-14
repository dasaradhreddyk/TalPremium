The following design principles used while implementing the premium calculation service.
1.	Clean architecture followed in implementing API module with API component, Model and service layer.
2.	Service  calculator has been injected to API end point.
3.	Creation pattern used to initiate all builder objects required.
4.	Angular component will consume API end point. UI implemented with following validations
i.	Amount value should be positive.
ii.	Any value is not given value , form will be validated.
iii.	Age calculated based on the date picker. It will be in years.
5.	Unit testing added with xunit which will unit test all the service end points and services.

     

![image](https://user-images.githubusercontent.com/58421595/173187085-aea8f2d8-0ae8-467a-b628-9fcf887cb2b6.png)
