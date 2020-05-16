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
                            {item.time}
                        </td>
                        <td>
                            {item.price}
                        </td>
                        <td>
                            {item.visits}
                        </td>
                        <td>
                            {item.number}
                        </td>
                    </tr>
                )}
            </tbody>
        </table>
    );
};

export default MainTable;