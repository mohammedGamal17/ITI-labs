var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
//#region 1- Create array that accept number only the cast value to string
var numbers = [];
numbers.push(1);
numbers.push(2);
numbers.push(5);
numbers.push(3);
numbers.push(4);
var stringNumbers = numbers.map(String);
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
var numbersAndString = [];
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
var DayOfWeek;
(function (DayOfWeek) {
    DayOfWeek[DayOfWeek["Saturday"] = 1] = "Saturday";
    DayOfWeek[DayOfWeek["Sunday"] = 2] = "Sunday";
    DayOfWeek[DayOfWeek["Monday"] = 3] = "Monday";
    DayOfWeek[DayOfWeek["Tuesday"] = 4] = "Tuesday";
    DayOfWeek[DayOfWeek["Wednesday"] = 5] = "Wednesday";
    DayOfWeek[DayOfWeek["Thursday"] = 6] = "Thursday";
    DayOfWeek[DayOfWeek["Friday"] = 7] = "Friday";
})(DayOfWeek || (DayOfWeek = {}));
// console.log(DayOfWeek.Saturday);
//#endregion
//#region 4- Create a variable that accept number and Boolean only
var x;
x = 10;
x = false;
function greet(firstParam, secondParam) {
    if (secondParam !== undefined)
        return "Hello, ".concat(firstParam, " ").concat(secondParam);
    else
        return "Hello, ".concat(firstParam);
}
console.log(greet("Mohammed"));
console.log(greet("Mohammed", "Gamal"));
var Employee = /** @class */ (function () {
    /**
     * Employee Constructor
     */
    function Employee(_id, _name, _username, _email, _address, _city, _zipCode, _geo) {
        this.id = _id;
        this.name = _name;
        this.username = _username;
        this.email = _email;
        this.address = _address;
        this.city = _city;
        this.geo = _geo;
    }
    Object.defineProperty(Employee.prototype, "getUsername", {
        get: function () {
            return this.username;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Employee.prototype, "setUsername", {
        set: function (_userName) {
            this.username = _userName;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Employee.prototype, "getAddress", {
        get: function () {
            return this.address;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Employee.prototype, "setAddress", {
        set: function (_address) {
            this.address = _address;
        },
        enumerable: false,
        configurable: true
    });
    return Employee;
}());
var emp = new Employee(1, "Mohammed Gamal", "Gemmy", "mohammed@gmail.com", { street: "5 Alex", suite: "3" }, "Alexandria", "123456789", { lat: "-37.3159", lng: "81.1496" });
// console.log(emp);
//#endregion
//#region 7- Create class manager inherit from employee class and
//a. Create a function to view employee address
var Manager = /** @class */ (function (_super) {
    __extends(Manager, _super);
    /**
     * Manager Constructor
     */
    function Manager(_mangerID, _id, _name, _username, _email, _address, _city, _zipCode, _geo) {
        var _this = _super.call(this, _id, _name, _username, _email, _address, _city, _zipCode, _geo) || this;
        _this._mangerID = _mangerID;
        return _this;
    }
    return Manager;
}(Employee));
var manger = new Manager(1, 1, "Mohammed Gamal", "Gemmy", "mohammed@gmail.com", { street: "5 Alex", suite: "3" }, "Alexandria", "123456789", { lat: "-37.3159", lng: "81.1496" });
console.log(manger.getAddress);
//#endregion
