import React from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';

const MainTable = ({ columns, tableData }) => {
    return (
        <table className="table table-hover">
            <thead>
                <tr>
                    {columns.map((item, id) =>
                        <th key={id}>
                            {item}
                        </th>)}
                </tr>
            </thead>
            <tbody>
                {tableData.map((item, id) =>
                    <tr key={id}>
                        <td>
                            {item.allname}
                        </td>
                        <td>
                            {item.ticketnumber}
                        </td>
                        <td>
                            {item.flat}
                        </td>
                        <td>
                            {item.house}
                        </td>
                        <td>
                            {item.street}
                        </td>
                        <td>
                            {item.town}
                        </td>
                        <td>
                            {item.country}
                        </td>
                    </tr>
                )}
            </tbody>
        </table>
    );
};

export default MainTable;