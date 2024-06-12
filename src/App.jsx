import { createBrowserRouter, RouterProvider } from 'react-router-dom';

import './App.css';

import HeaderLayout from './pages/HeaderLayout';
import HomePage from './pages/HomePage';
import ProductPage from './pages/ProductsPage';

const router = createBrowserRouter([
  {
    path: '/',
    element: <HeaderLayout />,
    children: [
      {
        index: true,
        element: <HomePage />,
      },
      {
        path: 'products',
        element: <ProductPage />,
      },
    ],
  },
]);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
