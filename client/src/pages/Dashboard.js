import React from 'react';
import {LineChart} from "@mui/x-charts";

const months = [
    "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
];

const Dashboard = () => {
    return (
        <div>
            <LineChart
                xAxis={[{
                    id: 'Months',
                    data: months,
                    scaleType: 'point'
                }]}
                series={[
                    {
                        label: 'Orders',
                        data: [2, 5.5, 2, 8.5, 1.5, 5],
                    },
                ]}
                width={500}
                height={300}
            />
        </div>
    );
};

export default Dashboard;