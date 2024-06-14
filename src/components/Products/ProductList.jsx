import { useHttp } from '../../hooks/useHttp';
import { useDispatch } from 'react-redux';

import ProductListItem from './ProductListItem';
import ErrorBlock from '../../UI/ErrorBlock';
import classes from './ProductList.module.css';

import { loadingStatusActions } from '../../store/loadingStatus';
let URL_CONFIG = {
  count: null,
};

/* eslint-disable react/prop-types */
export default function ProductList({ count }) {
  const dispatch = useDispatch();

  URL_CONFIG.count = count;
  const {
    data: products,
    isLoading,
    error,
  } = useHttp('products', [], URL_CONFIG); // TODO: tansack query

  function handleLoadingStatusChange(newStatus) {
    dispatch(loadingStatusActions.setLoadingStatus(newStatus));
  }

  let content;

  if (isLoading) {
    handleLoadingStatusChange('pending');
    content = <p>Loading data...</p>;
  }

  if (error) {
    handleLoadingStatusChange('error');
    content = (
      <ErrorBlock
        title={error.title}
        message={error.message}
      />
    );
  }

  if (!isLoading && !error && products.length > 0) {
    handleLoadingStatusChange('success');
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
