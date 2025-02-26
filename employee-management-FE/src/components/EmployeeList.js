import React, { useEffect, useState } from 'react';
import axios from 'axios';

const EmployeeList = () => {
    const [employees, setEmployees] = useState([]);
    const API_URL = "https://localhost:5001/api";

    useEffect(() => {
        axios.get(`${API_URL}/employees`)
            .then(response => setEmployees(response.data))
            .catch(error => console.error(error));
    }, []);

    return (
        <div>
            <h1>Employee List</h1>
            <ul>
                {employees.map(employee => (
                    <li key={employee.employeeId}>{employee.firstName} {employee.lastName} - {employee.position}</li>
                ))}
            </ul>
        </div>
    );
};

export default EmployeeList;