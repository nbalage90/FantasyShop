import { useDispatch } from 'react-redux';
import { useHttp } from '../../hooks/useHttp';

import ErrorBlock from '../../UI/ErrorBlock';
import classes from './Product.module.css';

import { cartActions } from '../../store/cart';

/* eslint-disable react/prop-types */
export default function Product({ productId }) {
  const dispatch = useDispatch();
  const {
    data: product,
    isLoading,
    error,
  } = useHttp(`products/${productId}`, {}, null);

  function addToCartHandler() {
    dispatch(cartActions.addItem(product));
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

  if (Object.keys(product).length > 0) {
    content = (
      <article>
        <section className={classes.uppersection}>
          <img
            src={`http://localhost:8000/images/${product.image}`}
            alt={product.name}
          />
          <h3>{product.name}</h3>
        </section>
        <section className={classes.uppersection}>
          <p>{product.price}</p>
          <button
            className="button"
            onClick={addToCartHandler}
          >
            Add to Cart
          </button>
        </section>
        <section>
          <p>{product.description}</p>
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
