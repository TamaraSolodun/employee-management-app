import React, { useEffect, useState } from 'react';
import axios from 'axios';

const EmployeeList = () => {
    const [employee, setEmployee] = useState([]);
    const API_URL = "http://localhost:5265/api";

    useEffect(() => {
        axios.get(`${API_URL}/employees/${employee.id}`)
            .then(response => setEmployees(response.data))
            .catch(error => console.error(error));
    }, []);

    return (
        <div>
            <h1>Employee List</h1>
            <ul>
                {employee.map(employee => (
                    <li key={employee.employeeId}>{employee.firstName} {employee.lastName} - {employee.position}</li>
                ))}
            </ul>
        </div>
    );
};

export default EmployeeList;