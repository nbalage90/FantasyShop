import ErrorBlock from '../../UI/ErrorBlock';
import { useHttp } from '../../hooks/useHttp';

import ProductListItem from './ProductListItem';
import classes from './ProductList.module.css';

let config = {
  count: null,
};

/* eslint-disable react/prop-types */
export default function ProductList({ count }) {
  config.count = count;
  const { data: products, isLoading, error } = useHttp('products', [], config); // TODO: tansack query

  let content;

  if (isLoading) {
    content = <p>Loading data...</p>;
  }

  if (error) {
    content = (
      <ErrorBlock
        title={error.title}
        message={error.message}
      />
    );
  }

  if (!isLoading && !error) {
    content = (
      <ul>
        {products.map((product) => (
          <li key={product.id}>
            <ProductListItem product={product} />
          </li>
        ))}
      </ul>
    );
  }

  return (
    <>
      <h2>Top products</h2>
      <article className={classes.productlist}>{content}</article>
    </>
  );
}
//
