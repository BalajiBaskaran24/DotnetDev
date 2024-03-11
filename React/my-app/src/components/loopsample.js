//How to loop a collection???

function EmployeeFun(props) {
  console.log("employee print" + props);
  return (
    <div>
      <p>Employee Id: {props.Key}</p>
      <p>Employee name: {props.data.Name}</p>
    </div>
  );
}

function DisplayEmployee(props) {
  console.log("enters dispaly fun prop");

  //Always recommended to pass Key for unique identification
  //of element from list
  const totalList = props.data.map((emp) => (
    <EmployeeFun Key={emp.id} data={emp}></EmployeeFun>
  ));
  return <div>{totalList}</div>;
}

export default DisplayEmployee;
