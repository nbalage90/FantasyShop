import { useHttp } from '../../hooks/useHttp';

import ProductItem from './ProductItem';
import classes from './ProductList.module.css';

/* eslint-disable react/prop-types */
export default function ProductList({ count }) {
  const { data: products } = useHttp([], { count }); // TODO: tansack query

  return (
    <>
      <h2>Top products</h2>
      <article className={classes.productlist}>
        <ul>
          {products.map((product) => (
            <li key={product.id}>
              <ProductItem product={product} />
            </li>
          ))}
        </ul>
      </article>
    </>
  );
}
