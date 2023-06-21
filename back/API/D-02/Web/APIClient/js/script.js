window.addEventListener("load", async function () {
  displayDepartment(await GetAllDepartments());
});

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
