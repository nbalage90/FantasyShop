import { useDispatch } from 'react-redux';
import { useHttp } from '../../hooks/useHttp';

import ErrorBlock from '../../UI/ErrorBlock';
import classes from './Product.module.css';

import { cartActions } from '../../store/cart';
import Button from '../../UI/Button';

/* eslint-disable react/prop-types */
export default function Product({ productId }) {
  const dispatch = useDispatch();
  const { data, isLoading, error } = useHttp(`products/${productId}`, {}, null);

  function addToCartHandler() {
    dispatch(cartActions.addItem(data.product));
  }

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

  if (Object.keys(data).length > 0) {
    content = (
      <article>
        <section className={classes.uppersection}>
          <img
            src={`http://localhost:6010/images/${data.product.image}`}
            alt={data.product.name}
          />
          <h3>{data.product.name}</h3>
        </section>
        <section className={classes.uppersection}>
          <p>{data.product.price}</p>
          <Button
            title="Add to Cart"
            className="button"
            onClick={addToCartHandler}
          />
        </section>
        <section>
          <p>{data.product.description}</p>
        </section>
      </article>
    );
  }

  return (
    <>
      <h2>Product page</h2>
      {content}
    </>
  );
}
