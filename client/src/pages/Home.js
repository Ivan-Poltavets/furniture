import React from 'react';
import {LineChart} from "@mui/x-charts";

const Home = () => {
    const months = [
        "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"
    ]

    return (
        <div>
            <LineChart
                xAxis={[{
                    scaleType: 'point',
                    data: months,
                },
                ]}
                series={[
                    {
                        label: 'Order count',
                        data: [2, 10, 2, 10, 3, 5],
                        stack: 'total',
                        area: true,
                        showMark: false
                    },
                    {
                        label: 'Total income',
                        data: [200, 400, 500, 600, 3, 5],
                        stack: 'total',
                        area: true,
                        showMark: false
                    }
                ]}
                width={500}
                height={300}
            />
        </div>
    );
};

export default Home;