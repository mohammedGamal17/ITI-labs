//#region 1- Create array that accept number only the cast value to string
let numbers: number[] = [];
numbers.push(1);
numbers.push(2);
numbers.push(5);
numbers.push(3);
numbers.push(4);
let stringNumbers: string[] = numbers.map(String);

// numbers
//   .sort((a, b) => a - b)
//   .forEach((element) => {
//     console.log(element);
//   });

// stringNumbers.forEach((element) => {
//   console.log(element);
// });
//#endregion

//#region 2- Create array that accept string and number only and print all items
let numbersAndString: (number | string)[] = [];
numbersAndString.push(1);
numbersAndString.push("Mohammed");
numbersAndString.push(5);
numbersAndString.push("Gamal");
numbersAndString.push(4);

// numbersAndString.forEach((element) => {
//   console.log(element);
// });
//#endregion

//#region 3- Create enum and add a unique number values for each enum value // search
enum DayOfWeek {
  Saturday = 1,
  Sunday,
  Monday,
  Tuesday,
  Wednesday,
  Thursday,
  Friday,
}

// console.log(DayOfWeek.Saturday);
//#endregion

//#region 4- Create a variable that accept number and Boolean only
let x: number | boolean;
x = 10;
x = false;
// x = "as"; //Error
//#endregion

//#region 5- Create function overloading with two parameter
function greet(name: string): string;
function greet(firstName: string, lastName: string): string;

function greet(firstParam: string, secondParam?: string): string {
  if (secondParam !== undefined) return `Hello, ${firstParam} ${secondParam}`;
  else return `Hello, ${firstParam}`;
}

console.log(greet("Mohammed"));
console.log(greet("Mohammed", "Gamal"));
//#endregion

//#region 6- Create class Employee implement IEmployee using this object as implementation
interface IEmployee {
  readonly id: number;
  get getUsername();
  name: string;
  email: string;
  get getAddress();
  city: string;
  zipCode: string;
  geo: { lat: string; lng: string };
}
class Employee implements IEmployee {
  readonly id: number;
  name: string;
  private username: string;
  email: string;
  protected address: { street: string; suite: string };
  city: string;
  zipCode: string;
  geo: { lat: string; lng: string };

  /**
   * Employee Constructor
   */
  constructor(
    _id: number,
    _name: string,
    _username: string,
    _email: string,
    _address: { street: string; suite: string },
    _city: string,
    _zipCode: string,
    _geo: { lat: string; lng: string }
  ) {
    this.id = _id;
    this.name = _name;
    this.username = _username;
    this.email = _email;
    this.address = _address;
    this.city = _city;
    this.geo = _geo;
  }

  get getUsername() {
    return this.username;
  }
  set setUsername(_userName: string) {
    this.username = _userName;
  }
  get getAddress() {
    return this.address;
  }
  set setAddress(_address: { street: string; suite: string }) {
    this.address = _address;
  }
}
let emp = new Employee(
  1,
  "Mohammed Gamal",
  "Gemmy",
  "mohammed@gmail.com",
  { street: "5 Alex", suite: "3" },
  "Alexandria",
  "123456789",
  { lat: "-37.3159", lng: "81.1496" }
);
// console.log(emp);
//#endregion

//#region 7- Create class manager inherit from employee class and
//a. Create a function to view employee address

class Manager extends Employee {
  /**
   * Manager Constructor
   */
  constructor(
    public _mangerID: number,
    _id: number,
    _name: string,
    _username: string,
    _email: string,
    _address: { street: string; suite: string },
    _city: string,
    _zipCode: string,
    _geo: { lat: string; lng: string }
  ) {
    super(_id, _name, _username, _email, _address, _city, _zipCode, _geo);
  }
}
let manger = new Manager(
  1,
  1,
  "Mohammed Gamal",
  "Gemmy",
  "mohammed@gmail.com",
  { street: "5 Alex", suite: "3" },
  "Alexandria",
  "123456789",
  { lat: "-37.3159", lng: "81.1496" }
);
console.log(manger.getAddress);
//#endregion
