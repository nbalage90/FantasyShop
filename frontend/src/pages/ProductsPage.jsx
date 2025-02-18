import { NavLink } from 'react-router-dom';

import ProductList from '../components/Products/ProductList';

export default function ProductsPage() {
  return (
    <>
      <NavLink to="/products/new">+ New Product</NavLink>
      <ProductList count={null} />
    </>
  );
}
