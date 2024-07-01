import { useHttp } from '../../hooks/useHttp';
import { useDispatch } from 'react-redux';

import ProductListItem from './ProductListItem';
import ErrorBlock from '../../UI/ErrorBlock';
import classes from './ProductList.module.css';

import { loadingStatusActions } from '../../store/loadingStatus';
import { useEffect, useState } from 'react';

let URL_CONFIG = {
  count: null,
};

const initialData = {
  products: [],
};

/* eslint-disable react/prop-types */
export default function ProductList({ count }) {
  const dispatch = useDispatch();
  const [loadingStatus, setLoadingStatus] = useState('none');

  URL_CONFIG.count = count;
  const { data, isLoading, error } = useHttp(
    'products',
    initialData,
    URL_CONFIG
  ); // TODO: tansack query && paging

  useEffect(() => {
    if (isLoading) {
      setLoadingStatus('pending');
    } else if (error) {
      setLoadingStatus('error');
    } else if (!isLoading && !error) {
      setLoadingStatus('success');
    }

    dispatch(loadingStatusActions.setLoadingStatus(loadingStatus));
  }, [loadingStatus, dispatch, error, isLoading]);

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
        {data.products.map((product) => (
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
