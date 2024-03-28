function employeeData(namesArr) {

    function assignId(namesArr) {

        let employeeList = [];
        for (let currentName of namesArr) {
            let currentId = currentName.length;
            employeeList.push([currentName, currentId]);
        }

        return employeeList;
    }

    function printEmployeeInfo(employeeList) {
        employeeList.forEach(([employeeName, employeeId]) => {
          console.log(`Name: ${employeeName} -- Personal Number: ${employeeId}`);
        });
      }
      
      let employeeData = assignId(namesArr);
      printEmployeeInfo(employeeData);

}

employeeData([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
]
);