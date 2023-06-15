import { ElementSchemaRegistry } from '@angular/compiler';
import { Component } from '@angular/core';

@Component({
  selector: 'app-content',
  templateUrl: './content.component.html',
  styleUrls: ['./content.component.css'],
})
export class ContentComponent {
  //#region Fields
  isStudentNameVeiled: boolean = false;
  isStudentAgeVeiled: boolean = false;

  studentName: string = '';
  studentAge?: number;

  studentArray: Student[] = [];

  //#endregion

  //#region Methods
  checkStudentName(studentName: any): void {
    if (studentName.value.length >= 3 && studentName.value.length <= 20)
      this.isStudentNameVeiled = true;
    else this.isStudentNameVeiled = false;
  }

  checkStudentAge(studentAge: any): void {
    if (studentAge.value >= 18 && studentAge.value < 60)
      this.isStudentAgeVeiled = true;
    else this.isStudentAgeVeiled = false;
  }

  insertIntoStudents(): void {
    this.studentArray.push(new Student(this.studentName, this.studentAge!));
  }
  deleteStudent(i: number): void {
    this.studentArray = this.studentArray.filter((item, index) => (i = index));
  }
  //#endregion
}

//#region Classes
/**
 * Student Class
 */
class Student {
  name: string;
  age: number;
  /**
   * Student Constructor
   */
  constructor(name: string, age: number) {
    this.name = name;
    this.age = age;
  }
}

//#endregion
