The following design principles following while implmenting the premium calculation service. 

1. Clean architecture followed in implementing API module with API component, Model and service layer. 
2. Serive calculator has been injected to API end point.
3. Creation pattern used to initiase all builder objects required. 
4. Angular component will consume api end point. UI implemented with following validations
    1. Amount value should be positive.
    2. Any value is not given value , form will be valiated.
    3. Age calculated based on the date picker. It will be in years.

5. Unit testing added with xunit which will unit test all the service end points and services.     

![image](https://user-images.githubusercontent.com/58421595/173187085-aea8f2d8-0ae8-467a-b628-9fcf887cb2b6.png)
