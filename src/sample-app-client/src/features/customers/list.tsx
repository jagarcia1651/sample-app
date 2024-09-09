import { useEffect, useState } from 'react';
import { Container, Typography, List, ListItem, ListItemText } from '@mui/material';

interface Customer {
    firstName: string;
    lastName: string;
}

const Customers = () => {
    const [customers, setCustomers] = useState<Customer[]>([]);
    const [loading, setLoading] = useState(true);

    const apiUrl = "https://localhost:5001/api"

    useEffect(() => {
        fetch(`${apiUrl}/abc/customers`)
            .then(response => response.json())
            .then(data => {
                setCustomers(data);
                setLoading(false);
            })
            .catch(error => {
                console.error('Error fetching customers:', error);
                setLoading(false);
            });
    }, []);

    if (loading) {
        return <Typography>Loading...</Typography>;
    }

    return (
        <Container>
            <Typography variant="h2" gutterBottom>
                Customers
            </Typography>
            <List>
                {customers.map(customer => (
                    <ListItem key={customer.firstName}>
                        <ListItemText
                            primary={customer.firstName}
                            secondary={customer.lastName}
                        />
                    </ListItem>
                ))}
            </List>
        </Container>
    );
};

export default Customers;
