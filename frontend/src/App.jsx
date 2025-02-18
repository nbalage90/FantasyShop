import { createBrowserRouter, RouterProvider } from 'react-router-dom';

import './App.css';

import HeaderLayout from './pages/HeaderLayout';
import HomePage from './pages/HomePage';
import ProductsPage from './pages/ProductsPage';
import ProductItemPage from './pages/ProductItemPage';
import NewProductPage from './pages/NewProductPage';

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
        element: <HeaderLayout />,
        children: [
          {
            index: true,
            element: <ProductsPage />,
          },
          {
            path: ':id',
            element: <ProductItemPage />,
          },
          {
            path: 'new',
            element: <NewProductPage />,
          },
        ],
      },
    ],
  },
]);

function App() {
  return <RouterProvider router={router} />;
}

export default App;
