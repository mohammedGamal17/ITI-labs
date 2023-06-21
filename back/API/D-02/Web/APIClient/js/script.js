window.addEventListener("load", async function () {
  displayDepartment(await GetAllDepartments());
  displayStudent(await GetAllStudents());
});

//#region Department

async function GetAllDepartments() {
  const url = `https://localhost:7111/api/department`;
  const response = await fetch(url);
  const data = await response.json();
  //   console.log(data);
  return data;
}

function displayDepartment(DepartmentData) {
  let tableTB = document.getElementById("tableTB");

  DepartmentData.forEach((element) => {
    tableTB.innerHTML += `
    <tr>
        <td>${element.id}</td>
        <td>${element.name}</td>
        <td>${element.description}</td>
    </tr>`;
  });
}

//#endregion

//#region Student
async function GetAllStudents() {
  let url = `https://localhost:7111/api/student`;
  const response = await fetch(url);
  const data = await response.json();
  return data;
}

function displayStudent(studentData) {
  let tableTBStudent = document.getElementById("tableTBStudent");
  studentData.forEach((element) => {
    if (element.id != undefined) {
      tableTBStudent.innerHTML += `
    <tr>
        <td>${element.id}</td>
        <td>${element.name}</td>
        <td>${element.email}</td>
        <td>${element.departmentName}</td>
        <td>${element.studentSuperName ?? "N/A"}</td>
    </tr>`;
    } else {
      tableTBStudent.innerHTML = `<tr><td colspan="5">There is no Record like this check ID</td></tr>`;
    }
  });
}
//#endregion
