import { Link } from 'react-router-dom';
import classes from './ProductListItem.module.css';

/* eslint-disable react/prop-types */
export default function ProductListItem({ product }) {
  return (
    <article className={classes.product}>
      <Link to={`/products/${product.id}`}>
        <img
          src={`http://localhost:8000/images/${product.image}`} // TODO
          alt={product.name}
        />
        <h3>{product.name}</h3>
        <p>{product.description}</p>
      </Link>
    </article>
  );
}
