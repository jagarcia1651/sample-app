import { Button, Container, Typography } from '@mui/material';
import { Routes, Route, Link } from 'react-router-dom';
import CustomerList from './Features/Customers/List';

function App() {
    return (
        <Container>
            <Typography variant="h1" gutterBottom>
                Welcome to the Sample App
            </Typography>
            <Button variant="contained" color="primary" component={Link} to="/customers">
                Go to Customer List
            </Button>

            <Routes>
                <Route path="/" element={<Home />} />
                <Route path="/customers" element={<CustomerList />} />
            </Routes>
        </Container>
    );
}

function Home() {
    return (
        <Typography>
            This is the home page.
        </Typography>
    );
}

export default App;
